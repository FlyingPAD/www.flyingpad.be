import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColumnFullComponent } from './column-full.component';

describe('ColumnFullComponent', () => {
  let component: ColumnFullComponent;
  let fixture: ComponentFixture<ColumnFullComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ColumnFullComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ColumnFullComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
