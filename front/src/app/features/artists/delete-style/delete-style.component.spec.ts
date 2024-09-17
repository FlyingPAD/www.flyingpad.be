import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteStyleComponent } from './delete-style.component';

describe('DeleteStyleComponent', () => {
  let component: DeleteStyleComponent;
  let fixture: ComponentFixture<DeleteStyleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeleteStyleComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DeleteStyleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
