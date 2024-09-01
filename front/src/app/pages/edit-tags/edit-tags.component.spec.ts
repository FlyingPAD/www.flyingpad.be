import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditTagsComponent } from './edit-tags.component';

describe('EditTagsComponent', () => {
  let component: EditTagsComponent;
  let fixture: ComponentFixture<EditTagsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditTagsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditTagsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
